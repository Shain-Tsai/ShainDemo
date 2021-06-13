using System;

namespace CloudServicePlatform.Api.Model
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        
        public DateTime LastActivityDate { get; set; }
    }
}