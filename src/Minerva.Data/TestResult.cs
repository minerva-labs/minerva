using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;

namespace Minerva.Data;

public class TestResult
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal Duration { get; set; }
        public Instant RunAt { get; set; }
        public TestResultFormat ResultType { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string Trigger { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;

        [Column(TypeName = "jsonb")]
        public string? ErrorMessage { get; set; }
}
