namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations.Infrastructure;

    public partial class MultipleClients : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201111300434138_MultipleClients"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
