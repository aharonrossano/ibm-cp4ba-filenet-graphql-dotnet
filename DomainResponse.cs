using System.Collections.Generic;

namespace GraphQL.Client.Example
{
    public class DomainResponse
    {
        public DomainContent Domain { get; set; }

        public class DomainContent
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
    }
}