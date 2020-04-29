using CIS_560_Proj.Items;
using System;
using System.Data.SqlClient;

namespace CIS_560_Proj.Movie_Delegates
{
    internal class GetDelegate : DataReaderDelegate<Movie>
    {
        private readonly string Name;

        public GetDelegate(string name)
           : base("GetMovieName")
        {
            this.Name = name;
        }

        public override void PrepareCommand(SqlCommand command)//overide
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieName", Name);
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Movie(Convert.ToInt32(reader.GetString("MovieId")),
               reader.GetInt32("ProductionId"),
                Name,
                "NULL", "NULL");
        }
    }
}
