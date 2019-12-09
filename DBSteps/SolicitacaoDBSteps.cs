﻿using jsonplaceholder.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonplaceholder.DBSteps
{
    public class SolicitacaoDBSteps
    {
        public static void AtualizaDataDoItemSolicitacaoParaAgoraDB(string solicitacaoItemId)
        {
            string query = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Queries/atualizaDataDoItemSolicitacaoParaAgora.sql", Encoding.UTF8);
            query = query.Replace("$solicitacaoItemId", solicitacaoItemId);

            DBHelpers.ExecuteQuery(query);

            ExtentReportHelpers.AddTestInfo(2, "PARAMETERS: solicitacaoItemId = " + solicitacaoItemId);
        }
    }
}
