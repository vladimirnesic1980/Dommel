using System;
using System.Reflection;
using static Dommel.DommelMapper;

namespace Dommel.PerformanceTests
{
    public class DummySqlBuilder : ISqlBuilder
    {
        public static DummySqlBuilder Instance = new DummySqlBuilder();

        public string BuildInsert(string tableName, string[] columnNames, string[] paramNames, PropertyInfo keyProperty)
        {
            throw new NotImplementedException();
        }

        public string BuildPaging(string orderBy, int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public string QuoteIdentifier(string identifier)
        {
            return identifier;
        }
    }
}
