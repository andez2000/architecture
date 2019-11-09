using System;

namespace Acme.MicroServices.Foo.Entities
{
	public class Alpha
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

		public string Description { get; set; }

		public int Number { get; set; }

		public DateTime? StartDate { get; set; }

		public decimal Price { get; set; }

		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

		public Guid UserId { get; set; }
		public User Owner { get; set; }
	}
}
