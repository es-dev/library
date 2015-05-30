using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Library.Code
{
    public class UtilityPOCO
    {
        private static string primaryKeyName = "Id";
        public static string PrimaryKeyName
        {
            get
            {
                return primaryKeyName;
            }
        }

        private static string dtoKeyName = "DtoKey";
        public static string DtoKeyName
        {
            get
            {
                return dtoKeyName;
            }
        }

        public static IEnumerable<TDto> Assemble<TDto>(IQueryable entities, bool recursive=false, bool references = true, bool collections = true)
        {
            try
            {
                if (entities != null)
                {
                    var dtos = new List<TDto>();
                    foreach (var entity in entities)
                    {
                        var dto = Assemble<TDto>(entity, recursive, references, collections);
                        if (dto != null)
                            dtos.Add(dto);
                    }
                    return dtos;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static TDto Assemble<TDto>(object entity, bool recursive = false, bool references = true, bool collections = true)
        {
            try
            {
                var dto = (TDto)Assemble(entity, typeof(TDto), recursive, references, collections);
                return dto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TDto);
        }

        private static object Assemble(object entity, Type typeDto, bool recursive, bool references, bool collections, object entityOwner = null)
        {
            try
            {
                if (entity != null)
                {
                    var dto = Activator.CreateInstance(typeDto);
                    Clone(entity, dto);
                    if (recursive || (!recursive && entityOwner == null)) //recursive=false --> caricamento solo 1° livello references/collections (default recursive=false)
                    {
                        if (references)
                            AssembleReferences(entity, entityOwner, dto, recursive, references, collections);
                        if (collections)
                            AssembleCollections(entity, dto, recursive, references, collections);
                    }
                    return dto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void AssembleReferences(object entity, object entityOwner, object dto, bool recursive, bool references, bool collections)
        {
            try
            {
                var properties = GetReferenceProperties(entity, entityOwner);
                if (properties != null)
                {
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var entityReference = GetValue(entity, propertyName);
                        if (entityReference != null)
                        {
                            var typeDtoReference = GetType(dto, propertyName);
                            var isOwner=IsOwner(entityReference, entity);
                            var referencesReference = references;
                            var collectionsReference = collections;
                            if(isOwner)
                            {
                                referencesReference = true;
                                collectionsReference = false;
                            }

                            var dtoReference = Assemble(entityReference, typeDtoReference, recursive, referencesReference, collectionsReference, entity);
                            SetValue(dto, propertyName, dtoReference);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void AssembleCollections(object entity, object dto, bool recursive, bool references, bool collections)
        {
            try
            {
                var properties = GetCollectionProperties(entity);
                if (properties != null)
                {
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var typeDtoItem = GetTypeItem(dto, propertyName);
                        if (typeDtoItem != null)
                        {
                            var typeDtoCollection = typeof(List<>).MakeGenericType(typeDtoItem);
                            var dtoCollection = (IList)Activator.CreateInstance(typeDtoCollection);
                            var entityCollection = (IEnumerable)GetValue(entity, propertyName);
                            if (entityCollection != null)
                            {
                                foreach (var entityItem in entityCollection)
                                {
                                    var dtoItem = Assemble(entityItem, typeDtoItem, recursive, references, collections, entity);
                                    if (dtoItem != null)
                                        dtoCollection.Add(dtoItem);
                                }
                                SetValue(dto, propertyName, dtoCollection);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static Type GetTypeItem(object dto, string propertyName)
        {
            try
            {
                var typeCollection = GetType(dto, propertyName);
                if (typeCollection != null)
                {
                    var type = typeCollection.GetGenericArguments().FirstOrDefault();
                    return type;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static Type GetType(object dto, string propertyName)
        {
            try
            {
                if (dto != null)
                {
                    var type = (from q in dto.GetType().GetProperties() where q.Name == propertyName select q.PropertyType).FirstOrDefault();
                    return type;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static bool IsOwner(object entityReference, object entity)
        {
            try
            {
                if (entityReference != null && entity != null)
                {
                    var properties = GetCollectionProperties(entityReference);
                    var count = (from q in properties where q.PropertyType.FullName.Contains(entity.GetType().FullName) select q).Count();
                    var isOwner = (count >= 1);
                    return isOwner;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static void Copy(object entity, object dto)
        {
            try
            {
                if (entity != null)
                {
                    var properties = entity.GetType().GetProperties();
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var value = GetValue(entity, propertyName);
                        SetValue(dto, propertyName, value);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void Clone(object entity, object dto)
        {
            try
            {
                if (entity != null)
                {
                    var properties = GetScalarProperties(entity);
                    foreach (var property in properties)
                    {
                        var propertyName = property.Name;
                        var value = GetValue(entity, propertyName);
                        SetValue(dto, propertyName, value);
                    }
                    CloneDtoKey(entity, dto);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void CloneDtoKey(object entity, object dto)
        {
            try
            {
                if (HasDtoKey(dto))
                {
                    var dtoKey = GetDtoKey(entity);
                    SetValue(dto, "DtoKey", dtoKey);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private static bool HasDtoKey(object dto)
        {
            try
            {
                if(dto!=null)
                {
                    var property = dto.GetType().GetProperty("DtoKey");
                    var hasDtoKey = (property != null);
                    return hasDtoKey;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static void SetValue(object dto, string propertyName, object value)
        {
            try
            {
                if (dto != null)
                {
                    var property = dto.GetType().GetProperty(propertyName);
                    if (property != null)
                        property.SetValue(dto, value, null);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static object GetValue(object entity, string propertyName)
        {
            try
            {
                if (entity != null)
                {
                    var property = entity.GetType().GetProperty(propertyName); 
                    if (property != null)
                    {
                        var value = property.GetValue(entity, null);
                        return value;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IEnumerable<PropertyInfo> GetScalarProperties(object entity)
        {
            try
            {
                if (entity != null)
                {
                    var collectionProperties = GetCollectionProperties(entity);
                    var referenceProperties = GetReferenceProperties(entity);
                    var properties = (from q in entity.GetType().GetProperties() where !collectionProperties.Contains(q) && !referenceProperties.Contains(q) select q);
                    return properties;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IEnumerable<PropertyInfo> GetCollectionProperties(object entity)
        {
            try
            {
                if (entity != null)
                {
                    var properties = (from q in entity.GetType().GetProperties() where q.PropertyType.GetInterface("IEnumerable") != null && !q.PropertyType.IsSealed select q);
                    return properties;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IEnumerable<PropertyInfo> GetReferenceProperties(object entity, object entityOwner = null)
        {
            try
            {
                if (entity != null)
                {
                    var properties = (from q in entity.GetType().GetProperties() where q.PropertyType.IsClass && !q.PropertyType.IsSealed select q);
                    if (entityOwner != null)
                        properties = (from q in properties where q.PropertyType != entityOwner.GetType() select q);
                    return properties;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
                
        public static TEntity GetObject<TEntity>(TEntity obj)
        {
            try
            {
                if (obj == null)
                    obj = Activator.CreateInstance<TEntity>();
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return default(TEntity);
        }

        public static ICollection<TEntity> GetList<TEntity>(ICollection<TEntity> collection)
        {
            try
            {
                if (collection == null)
                    collection = new List<TEntity>(); 
                return collection;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static object GetPrimaryKeyValue(object entity)
        {
            try
            {
                var primaryKeyValue = GetValue(entity, primaryKeyName);
                return primaryKeyValue;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetDtoKey(object entity) 
        {
            try
            {
                var primaryKeyValue = GetValue(entity, primaryKeyName);
                var dtoKey = primaryKeyName + "=" + primaryKeyValue;
                return dtoKey;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetDtoKey(int id)
        {
            try
            {
                var dtoKey = primaryKeyName + "=" + id;
                return dtoKey;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static int GetId(string dtoKey)
        {
            try
            {
                if(dtoKey!=null && dtoKey.Contains(primaryKeyName))
                {
                    var id = int.Parse(dtoKey.Replace(primaryKeyName + "=", ""));
                    return id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
