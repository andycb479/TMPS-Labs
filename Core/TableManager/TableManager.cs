using System.Collections.Generic;

namespace Core.TableManager
{
     public class TableManager
     {
          private readonly Dictionary<string, TablePrototype> _tables = new();

          public TablePrototype this[string key]
          {
               get => _tables[key];
               set => _tables.Add(key, value);
          }
     }
}