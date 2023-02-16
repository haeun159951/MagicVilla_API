using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models
{
	public class Villa
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
	}
	
}

