using Domain;
using DAL.QueryLibrary;
namespace DAL
{
   public class ClientsDAO
    {
        private DapperContext Context;
        public ClientsDAO(DapperContext _context)
        {
            this.Context = _context;
        }

        public List<TestClass> SelectTestClass()
        {
            return Context.ModeledQuery<TestClass>(ClientsQueries.SELECT_TESTCLASS_ALL);
        }
    }
}
