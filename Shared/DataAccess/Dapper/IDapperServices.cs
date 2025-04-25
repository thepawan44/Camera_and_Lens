﻿using Shared.Model;
using System.Data;

namespace Shared.DataAccess.Dapper
{
    public interface IDapperServices
    {
        Task<SystemResponseModel> ExecuteAsync(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<T>> GetQueryResultAsync<T>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<T> GetQueryFirstOrDefaultResultAsync<T>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1, T2>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1, T2, T3>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
    }
}
