using SQLite;

namespace ForeignExchange.Data.Prototypes
{
    public abstract class Entity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}