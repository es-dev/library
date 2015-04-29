using Aspose.Words.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Library.Code;
using System.Drawing;

namespace Library.Code
{
    public class UtilityReport
    {

        public static bool Create(string pathTemplate, string pathReport, IList<Report> reports)
        {
            try
            {
                if (pathTemplate != null && pathReport != null && reports!=null)
                {
                    var performed = false;
                    var ext = Path.GetExtension(pathTemplate).ToUpper();
                    if (ext == ".DOC")
                        performed = CreateWord(pathTemplate, pathReport, reports);
                    else if (ext == ".XLS")
                        performed = CreateExcel(pathTemplate, pathReport, reports);

                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public static bool Create(string pathTemplate, string pathReport, Report report)
        {
            try
            {
                if (pathTemplate != null && pathReport != null && report!=null)
                {
                    var performed = false;
                    var ext = Path.GetExtension(pathTemplate).ToUpper();
                    if (ext == ".DOC")
                        performed = CreateWord(pathTemplate, pathReport, report);
                    else if (ext == ".XLS")
                        performed = CreateExcel(pathTemplate, pathReport, report);

                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static bool CreateExcel(string pathTemplate, string pathReport, IList<Report> reports)
        {
            try
            {
                var workbook = new Spire.Xls.Workbook();
                workbook.Worksheets.Clear();
                foreach (var report in reports)
                {
                    var workbookReport = CreateWorkbook(pathTemplate, report);
                    if (workbookReport != null)
                    {
                        var worksheets = workbookReport.Worksheets;
                        foreach (var worksheet in worksheets)
                            workbook.Worksheets.Add(worksheet);
                    }
                }
                var performed = SaveWoorkbook(workbook, pathReport);
                return performed;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static bool CreateWord(string pathTemplate, string pathReport, IList<Report> reports)
        {
            try
            {
                var document = new Aspose.Words.Document();
                document.RemoveAllChildren();
                foreach (var report in reports)
                {
                    var documentReport = CreateDocument(pathTemplate, report);
                    document.AppendDocument(documentReport, Aspose.Words.ImportFormatMode.KeepSourceFormatting);
                }
                var performed = SaveDocument(document, pathReport);
                return performed;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static bool SaveDocument(Aspose.Words.Document document, string pathReport)
        {
            try
            {
                var saveFormat = GetSaveFormat(pathReport);
                var output = document.Save(pathReport, saveFormat);
                var performed = (output != null);
                return performed;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static Aspose.Words.SaveFormat GetSaveFormat(string pathReport)
        {
            try
            {
                if (pathReport != null)
                {
                    var ext = Path.GetExtension(pathReport).ToUpper();
                    if (ext == "DOC")
                        return Aspose.Words.SaveFormat.Doc;
                    else if (ext == "PDF")
                        return Aspose.Words.SaveFormat.Pdf;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Aspose.Words.SaveFormat.Pdf;
        }

        private static bool CreateExcel(string pathTemplate, string pathReport, Report report)
        {
            try
            {
                var workbook = CreateWorkbook(pathTemplate, report);
                bool performed = SaveWoorkbook(workbook, pathReport);
                return performed;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static bool SaveWoorkbook(Spire.Xls.Workbook workbook, string pathReport)
        {
            try
            {
                if (workbook != null)
                {
                    workbook.UnProtect();
                    var worksheets = workbook.Worksheets;
                    foreach (var worksheet in worksheets)
                        worksheet.Unprotect("");

                    workbook.SaveToFile(pathReport);
                    return true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static Spire.Xls.Workbook CreateWorkbook(string pathTemplate, Report report)
        {
            try
            {
                var workbook = new Spire.Xls.Workbook();
                workbook.LoadFromFile(pathTemplate);
                var datas = report.Datas;
                var tables = report.Tables;

                BindViewTables(workbook, tables);
                BindViewDatas(workbook, datas);

                return workbook;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static void BindViewTables(Spire.Xls.Workbook workbook, IList<Table> tables)
        {
            try
            {
                if (tables != null)
                {
                    foreach (var table in tables)
                    {
                        var columns = table.Columns;
                        var _table = GetTable(workbook, columns);
                        BindViewTable(_table, table);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void BindViewTable(TableXls _table, Table table)
        {
            try
            {
                if (table != null && _table != null)
                {
                    var _range = _table.Range;
                    var worksheet = _table.Worksheet;
                    int _row = _range.Row + 1;
                    var rows = table.Rows;
                    foreach (var row in rows)
                    {
                        int _column = _range.Column;
                        var cells = row.Cells;
                        foreach (var cell in cells)
                        {
                            var value = cell.Value;
                            worksheet.SetText(_row, _column, value);
                            _column += 1;
                        }
                        _row += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static TableXls GetTable(Spire.Xls.Workbook workbook, IList<string> columns)
        {
            try
            {
                if (columns != null && workbook != null)
                {
                    var columnHeader = columns.FirstOrDefault();
                    var worksheets = workbook.Worksheets;
                    foreach (var worksheet in worksheets)
                    {
                        var range = (from q in worksheet.Cells where q.Text == columnHeader select q).FirstOrDefault();
                        if (range != null)
                        {
                            bool found = IsSameHeader(worksheet, range, columns);
                            if (found)
                            {
                                var table = new TableXls();
                                table.Range = range;
                                table.Worksheet = worksheet;
                                return table;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static bool IsSameHeader(Spire.Xls.Core.IWorksheet worksheet, Spire.Xls.Core.IXLSRange range, IList<string> columns)
        {
            try
            {
                if (worksheet != null && range != null && columns != null)
                {
                    var col = range.Column;
                    var row = range.Row;
                    foreach (var column in columns)
                    {
                        var _column = worksheet.GetText(row, col);
                        if (_column != column)
                            return false;
                        col += 1;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static void BindViewDatas(Spire.Xls.Workbook workbook, IList<Data> datas)
        {
            try
            {
                if (datas != null)
                {
                    foreach (var data in datas)
                    {
                        var name = data.Name;
                        var value = UtilityValidation.GetStringCleaned(data.Value);
                        var worksheets = workbook.Worksheets;
                        foreach (var worksheet in worksheets)
                            worksheet.Replace(name, value);
                    
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static bool CreateWord(string pathTemplate, string pathReport, Report report)
        {
            try
            {
                var document = CreateDocument(pathTemplate, report);
                var performed = SaveDocument(document, pathReport);
                return performed;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static Aspose.Words.Document CreateDocument(string pathTemplate, Report report)
        {
            try
            {
                var document = new Aspose.Words.Document(pathTemplate);
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
                if (tables != null)
                {
                    foreach (var table in tables)
                    {
                        var _tables = GetTables(document, table);
                        var _table = _tables.FirstOrDefault();
                        int rowsCount = GetRowsCount(_table);
                        int _count = rowsCount * _tables.Count;
                        int count = table.Rows.Count;
                        int pages = 0;
                        if(_count>0)
                            pages=(count - 1) / _count + 1;

                        var _section = GetSection(_table); //todo: prevedere gestione layout dinamico con inserimento row in 1° tabella
                        var index = GetIndex(document, _section);
                        for (int page = 2; page <= pages; page++)
                            document.Sections.Insert(index, _section.Clone(true));

                    }
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
                if (rows != null)
                {
                    var count = rows.Count;
                    return count;
                }
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
                if (table != null)
                {
                    var rows = table.Rows;
                    var _rows = new List<Aspose.Words.Tables.Row>();
                    foreach (Aspose.Words.Tables.Row row in rows)
                    {
                        var cell = row.FirstCell;
                        if (cell.Range.Text.Contains("$"))
                            _rows.Add(row);
                    }
                    return _rows;
                }
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
                if (table != null)
                {
                    var tables = GetTables(document);
                    if (tables != null)
                    {
                        var _tables = (from Aspose.Words.Tables.Table q in tables where IsSameHeader(q, table) select q).ToList();
                        return _tables;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static bool IsSameHeader(Aspose.Words.Tables.Table _table, Table table)
        {
            try
            {
                if (_table != null && table != null)
                {
                    var _header = GetHeader(_table.Rows);
                    var header = GetHeader(table.Columns);
                    var isSame = (_header!=null && header!=null && _header == header);
                    return isSame;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
       
        private static string GetHeader(IList<string> columns)
        {
            try
            {
                if (columns != null)
                {
                    string header = null;
                    foreach(var columnName in columns)
                        header += "$" + columnName + "$";
                    
                    return header;
                }
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
                if (rows != null)
                {
                    string header = null;
                    var row = GetFirstRow(rows);
                    if (row != null)
                    {
                        var cells = row.Cells;
                        foreach (Aspose.Words.Tables.Cell cell in cells)
                            header += UtilityValidation.GetStringCleaned(cell.Range.Text);

                        return header;
                    }
                }
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
                if (rows != null)
                {
                    foreach (Aspose.Words.Tables.Row row in rows)
                    {
                        var cells = row.Cells.ToArray();
                        var cell = (from q in cells select q).FirstOrDefault();
                        if (cell.Range.Text.StartsWith("$"))
                            return row;
                    }
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
                if (document != null)
                {
                    var _sections = document.Sections;
                    int index = 0;
                    foreach (var _section in _sections)
                    {
                        if (_section == section)
                            return index;
                        index += 1;
                    }
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
                if (table != null)
                {
                    var body = (Aspose.Words.Body)table.ParentNode;
                    var section = body.ParentSection;
                    return section;
                }
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
                if (tables != null)
                {
                    foreach (var table in tables)
                    {
                        var _tables = GetTables(document, table);
                        BindViewTable(_tables, table);
                    }
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
                if (_tables != null && table != null)
                {
                    int skip = 0;
                    var take = GetRowsCount(_tables.FirstOrDefault());
                    foreach (Aspose.Words.Tables.Table _table in _tables)
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
                    int index = 0;
                    foreach (var cell in cells)
                    {
                        var name = cell.Name;
                        var value = UtilityValidation.GetStringCleaned(cell.Value);
                        _row.Range.Replace(name, value, false, false);

                        if (row.Merged)
                        {
                            var _cell = _row.Cells[index];
                            _cell.CellFormat.HorizontalMerge = (index == 0 ? Aspose.Words.Tables.CellMerge.First : Aspose.Words.Tables.CellMerge.Previous);
                            _cell.CellFormat.Shading.BackgroundPatternColor = row.MergeColor;
                        }
                        index += 1;
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
                if (document != null)
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
                if (datas != null)
                {
                    foreach (var data in datas)
                    {
                        var name = data.Name;
                        var value = UtilityValidation.GetStringCleaned(data.Value);
                        document.Range.Replace(name, value, false, false);
                    }
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

            public void AddData(string name, object value, TypeFormat format = TypeFormat.None)
            {
                try
                {
                    var _name = "$" + name + "$";
                    object valueFormatted = value;
                    if (format == TypeFormat.StringND)
                        valueFormatted = UtilityValidation.GetStringND(value);
                    else if (format == TypeFormat.Euro)
                        valueFormatted = UtilityValidation.GetEuro((decimal?)value);
                    else if (format == TypeFormat.DateDDMMYYYY)
                        valueFormatted = UtilityValidation.GetDataND((DateTime?)value);
                    else
                        valueFormatted = UtilityValidation.GetStringEmpty(value);

                    var _value = (string)valueFormatted;
                    var data = new Data(_name, _value);
                    this.Datas.Add(data);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public bool Create(string pathTemplate, string pathReport)
            {
                try
                {
                    var performed = UtilityReport.Create(pathTemplate, pathReport, this);
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
            public IList<string> Columns = null;
            public IList<Row> Rows = null;

            public Table(params string[] columns)
            {
                try
                {
                    this.Columns = columns.ToList();
                    this.Rows = new List<Row>();
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public void AddRow(params string[] values )
            {
                try
                {
                    var row = new Row(this, false, Color.Transparent, values);
                    this.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

            public void AddRowMerge(Color mergeColor, params string[] values)
            {
                try
                {
                    var row = new Row(this, true, mergeColor, values);
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
            public bool Merged = false;
            public Color MergeColor = Color.Transparent;

            public Row(Table table, bool merged, Color mergeColor,  params string[] values)
            {
                try
                {
                    this.MergeColor = mergeColor;
                    this.Merged = merged;
                    this.Table = table;
                    this.Cells = new List<Cell>();
                    for (int column = 0; column < values.Length; column++)
                    {
                        var name = this.Table.Columns[column];
                        var value = values[column];
                        var _name = "$" + name + "$";
                        var _value = UtilityValidation.GetStringEmpty(value);
                        AddCell(_name, _value);
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

        public class TableXls
        {
            public Spire.Xls.Core.IWorksheet Worksheet = null;
            public Spire.Xls.Core.IXLSRange Range = null;

            public TableXls()
            {

            }
        }
    }
}
