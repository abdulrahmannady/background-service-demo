using System.Collections.Generic;
using System.Threading.Tasks;
using WorkerServicesDemo.Data.DatabaseSpecific;
using WorkerServicesDemo.Data.EntityClasses;
using WorkerServicesDemo.Data.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using System.Linq;

namespace WorkerServicesDemo.Controllers
{
    public static class Demo
    {
        public async static Task<bool> New(DemoEntity demo)
        {
            bool operationSuccessful = false;

            using (var adapter = new DataAccessAdapter())
            {
                operationSuccessful = await adapter.SaveEntityAsync(demo, refetchAfterSave: false); // no need to qurey back to get the last result
            }

            return operationSuccessful;
        }

        public async static Task<IEnumerable<DemoEntity>> GetAllDemos()
        {
            using (var adapter = new DataAccessAdapter())
            {
                var metaData = new LinqMetaData(adapter);

                var query = from u in metaData.Demo
                            select u;

                return await query.ToListAsync();
            }
        }

        public static void ClearTable()
        {
            using (var adapter = new DataAccessAdapter())
            {
                adapter.ExecuteSQL("DELETE FROM \"Demo\" ");
            }
        }
    }
}
