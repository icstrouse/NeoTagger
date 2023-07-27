using System.ComponentModel.DataAnnotations;

namespace NeoTagger.Models;

public class Tag
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public double Lat { get; set; }
    public double Lng { get; set; }
    public bool Public { get; set; }
    public bool Archived { get; set; }
    [DataType(DataType.Date)]
    public DateTime InsertedAt { get; set; }
}