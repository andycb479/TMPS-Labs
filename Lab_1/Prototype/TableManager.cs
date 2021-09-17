using System.Collections.Generic;

namespace Prototype.RealWorld
{
     public class TableManager
     {
          private Dictionary<string, TablePrototype> _tables = new Dictionary<string, TablePrototype>();

          public TablePrototype this[string key]
          {
               get { return _tables[key]; }
               set { _tables.Add(key, value); }
          }
     }
}