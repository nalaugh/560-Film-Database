using CIS_560_Proj.Items;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CIS_560_Proj.Movie_Delegates
{
    internal class DeleteDelegate : DataReaderDelegate<Movie>
    {
        public readonly int ProductionId;
        public readonly string MovieName;
        public readonly string ReleaseDate;
        public readonly int Moie;


        public DeleteDelegate(int Movie,int ProductionId, string MovieName, string ReleaseDate)
           : base("DeleteMovie")
        {
            this.ProductionId = ProductionId;
            this.MovieName = MovieName;
            this.ReleaseDate = ReleaseDate;
            this.Moie = Movie;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);



            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = MovieName;
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            return new Movie(Moie, ProductionId, MovieName, ReleaseDate, "Delete");
        }
    }

    internal class UpdateDelegate : NonQueryDataDelegate<Movie>
    {
        public readonly string ProductionId;
        public readonly string MovieName;
        public readonly string ReleaseDate;
        public readonly int Moie;


        public UpdateDelegate(int Movie, string ProductionId, string MovieName, string ReleaseDate)
           : base("UpdateMovie")
        {
            this.ProductionId = ProductionId;
            this.MovieName = MovieName;
            this.ReleaseDate = ReleaseDate;
            this.Moie = Movie;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ProductionId", SqlDbType.NVarChar);
            p.Value = ProductionId;

            p = command.Parameters.Add("MovieName", SqlDbType.NVarChar);
            p.Value = MovieName;
            p = command.Parameters.Add("ReleaseDate", SqlDbType.NVarChar);
            p.Value = ReleaseDate;

            p = command.Parameters.Add("MovieId", SqlDbType.Int);
            p.Value = Moie;
        }

        public override Movie Translate(SqlCommand command)
        {
            return new Movie((int)command.Parameters["MovieId"].Value, Convert.ToInt32(ProductionId), MovieName, ReleaseDate, "NULL");
        }
    }
}
