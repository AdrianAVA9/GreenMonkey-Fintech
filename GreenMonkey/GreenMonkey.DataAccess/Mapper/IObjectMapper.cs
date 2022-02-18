using GreenMonkey.Models;
using System.Collections.Generic;

namespace GreenMonkey.DataAccess.Mapper
{
    interface IObjectMapper
    {
        List<BaseEntity> BuildObjects(List<Dictionary<string,object>> lstRows);
        BaseEntity BuildObject(Dictionary<string, object> row);
    }
}