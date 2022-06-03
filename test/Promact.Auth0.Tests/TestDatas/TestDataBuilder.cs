using Promact.Auth0.EntityFrameworkCore;

namespace Promact.Auth0.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly Auth0DbContext _context;

        public TestDataBuilder(Auth0DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}