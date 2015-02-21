﻿using Aspose.Words.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Library.Code
{
    public class UtilityReport
    {

        public static bool Create(string pathTemplateWord, string pathReportPDF, IList<Report> reports)
        {
            try
            {
                var document = new Aspose.Words.Document();
                document.RemoveAllChildren();
                foreach(var report in reports)
                {
                    var documentReport = CreateDocument(pathTemplateWord, report);
                    document.AppendDocument(documentReport, Aspose.Words.ImportFormatMode.KeepSourceFormatting);
                }
                var output = document.Save(pathReportPDF, Aspose.Words.SaveFormat.Pdf);
                var performed = (output != null);
                return performed;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }


        public static bool Create(string pathTemplateWord, string pathReportPDF, Report report)
        {
            try
            {
                var document = CreateDocument(pathTemplateWord, report);
                var output = document.Save(pathReportPDF, Aspose.Words.SaveFormat.Pdf);
                var performed = (output != null);
                return performed;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static Aspose.Words.Document CreateDocument(string pathTemplateWord, Report report)
        {
            try
            {
                var document = new Aspose.Words.Document(pathTemplateWord);
                var datas = report.Datas;
                var tables = report.Tables;
                BuildSections(document, tables);

                BindViewTables(document, tables);
                BindViewDatas(document, datas);

                return document;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void BuildSections(Aspose.Words.Document document, IList<Table> tables)
        {
            try
            {
                foreach(var table in tables)
                {
                    var _tables = GetTables(document, table);
                    var _table = _tables.FirstOrDefault();
                    int rowsCount = GetRowsCount(_table);
                    int _count = rowsCount * _tables.Count;
                    int count = table.Rows.Count;
                    int pages = (count - 1) / _count + 1;

                    var _section = GetSection(_table);
                    var index = GetIndex(document, _section);
                    for(int page=2; page<=pages; page++)
                        document.Sections.Insert(index, _section.Clone(true));
                
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static int GetRowsCount(Aspose.Words.Tables.Table table)
        {
            try
            {
                var rows = GetRows(table);
                var count = rows.Count;
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private static IList<Aspose.Words.Tables.Row> GetRows(Aspose.Words.Tables.Table table)
        {
            try
            {
                var _rows = new List<Aspose.Words.Tables.Row>();
                var rows = table.Rows;
                foreach (Aspose.Words.Tables.Row row in rows)
                {
                    var cell = row.FirstCell;
                    if (cell.Range.Text.Contains("$"))
                        _rows.Add(row);
                }
                return _rows;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IList<Aspose.Words.Tables.Table> GetTables(Aspose.Words.Document document, Table table)
        {
            try
            {
                var tables = GetTables(document);
                var _tables = (from Aspose.Words.Tables.Table q in tables where GetHeader(q.Rows) == GetHeader(table.Rows) select q).ToList();
                return _tables;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static string GetHeader(IList<Row> rows)
        {
            try
            {
                string header = null;
                var row = (from q in rows select q).FirstOrDefault();
                var cells = row.Cells;
                foreach (var cell in cells)
                    header += cell.Name;
                
                return header;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static string GetHeader(Aspose.Words.Tables.RowCollection rows)
        {
            try
            {
                string header = null;
                var row = GetFirstRow(rows);
                var cells = row.Cells;
                foreach(Aspose.Words.Tables.Cell cell in cells)
                    header += cell.Range.Text.Replace("\a","");
                
                return header;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static Aspose.Words.Tables.Row GetFirstRow(Aspose.Words.Tables.RowCollection rows)
        {
            try
            {
                foreach(Aspose.Words.Tables.Row row in rows)
                {
                    var cells = row.Cells.ToArray();
                    var cell = (from q in cells select q).FirstOrDefault();
                    if (cell.Range.Text.StartsWith("$"))
                        return row;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static int GetIndex(Aspose.Words.Document document, Aspose.Words.Section section)
        {
            try
            {
                var _sections = document.Sections;
                int index = 0;
                foreach(var _section in _sections)
                {
                    if (_section == section)
                        return index;
                    index += 1;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private static Aspose.Words.Section GetSection(Aspose.Words.Tables.Table table)
        {
            try
            {
                var body = (Aspose.Words.Body)table.ParentNode;
                var section = body.ParentSection;
                return section;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void BindViewTables(Aspose.Words.Document document, IList<Table> tables)
        {
            try
            {
                foreach (var table in tables)
                {
                    var _tables = GetTables(document, table);
                    BindViewTable(_tables, table);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void BindViewTable(IList<Aspose.Words.Tables.Table> _tables, Table table)
        {
            try
            {
                int skip = 0;
                var take = GetRowsCount(_tables.FirstOrDefault());
                foreach(Aspose.Words.Tables.Table _table in _tables)
                {
                    var index = 0;
                    var rows = (from q in table.Rows select q).Skip(skip).Take(take).ToList();
                    var _rows = GetRows(_table);
                    foreach (var _row in _rows)
                    {
                        Row row = null;
                        if (index < rows.Count)
                            row = rows[index];
                        BindViewRow(_row, row);
                        index += 1;
                    }
                    skip += take;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void BindViewRow(Aspose.Words.Tables.Row _row, Row row)
        {
            try
            {
                if (row != null)
                {
                    var cells = row.Cells;
                    foreach (var cell in cells)
                    {
                        var name = cell.Name;
                        var value = cell.Value;
                        _row.Range.Replace(name, value, false, false);
                    }
                }
                else
                {
                    var _cells=_row.Cells;
                    foreach(Aspose.Words.Tables.Cell _cell in _cells)
                    {
                        _cell.RemoveAllChildren();
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private static IList<Aspose.Words.Tables.Table> GetTables(Aspose.Words.Document document)
        {
            try
            {
                var tables = new List<Aspose.Words.Tables.Table>();
                var sections = document.Sections;
                foreach (Aspose.Words.Section section in sections)
                {
                    var _tables = section.Body.Tables;
                    foreach (Aspose.Words.Tables.Table _table in _tables)
                        tables.Add(_table);
                }
                return tables;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void BindViewDatas(Aspose.Words.Document document, IList<Data> datas)
        {
            try
            {
                foreach (var data in datas)
                {
                    var name = data.Name;
                    var value = data.Value;
                    document.Range.Replace(name, value, false, false);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public class Report
        {
            public IList<Data> Datas = null;
            public IList<Table> Tables = null;

            public Report()
            {
                try
                {
                    this.Datas = new List<Data>();
                    this.Tables = new List<Table>();
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public void AddData(string name, string value)
            {
                try
                {
                    var _name = "$" + name + "$";
                    var data = new Data(_name, value);
                    this.Datas.Add(data);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public bool Create(string pathTemplateWord, string pathReportPDF)
            {
                try
                {
                    var performed = UtilityReport.Create(pathTemplateWord, pathReportPDF, this);
                    return performed;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return false;
            }


        }

        public class Table
        {
            public IList<string> Header = null;
            public IList<Row> Rows = null;

            public Table(params string[] header)
            {
                try
                {
                    this.Header = header.ToList();
                    this.Rows = new List<Row>();
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public void AddRow(params string[] values)
            {
                try
                {
                    var row = new Row(this, values);
                    this.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

        }

        public class Row
        {
            public UtilityReport.Table Table = null;
            public IList<Cell> Cells = null;

            public Row(Table table, params string[] values)
            {
                try
                {
                    this.Table = table;
                    this.Cells = new List<Cell>();
                    for (int index = 0; index < values.Length; index++)
                    {
                        var name = "$" + this.Table.Header[index] + "$";
                        var value = values[index];
                        AddCell(name, value);
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public void AddCell(string name, string value)
            {
                try
                {
                    var cell = new Cell(this, name, value);
                    this.Cells.Add(cell);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }
        }

        public class Cell : Data
        {
            public UtilityReport.Row Row = null;

            public Cell(Row row, string name, string value) : base(name, value)
            {
                try
                {
                    this.Row = row;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }
        }

        public class Data
        {
            public string Name = null;
            public string Value = null;
            
            public Data(string name, string value)
            {
                try
                {
                    this.Name = name;
                    this.Value = value;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }
        }

    }
}
