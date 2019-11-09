using System;

namespace Acme.MicroServices.Foo.Models
{
    public class AlphaModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

		public string Description { get; set; }

		public int Number { get; set; }

		public DateTime? StartDate { get; set; }

		public decimal Price { get; set; }

		public Guid UserId { get; set; }
		public Guid CategoryId { get; set; }

	}

	public class AlphaDetails
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int Number { get; set; }

		public DateTime? StartDate { get; set; }

		public decimal Price { get; set; }

		public string Category { get; set; }

		public string Owner { get; set; }
	}

	public class AlphaSummary
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

	}
}
