using Aspose.Words.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityReport
    {
        public static bool Create(string pathTemplateWord, string pathReportPDF, IList<ReportData> reportsData)
        {
            try
            {
                var document = new Aspose.Words.Document(pathTemplateWord);
                foreach (var reportData in reportsData)
                {
                    var name = reportData.Name;
                    var value = reportData.Value;
                    document.Range.Replace(name, value, false, false);
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

        public class ReportData
        {
            public string Name = null;
            public string Value = null;

            public ReportData()
            {

            }
        }

    }
}
