using System.Data.Entity.ModelConfiguration;
using KMA.APZRP2019.WalletSimulator.DBModels;

namespace KMA.APZRP2019.WalletSimulator.EntityFrameworkWrapper.ModelConfiguration
{
    class DogConfiguration : EntityTypeConfiguration<Dog>
    {
        public DogConfiguration()
        {
            ToTable("Psina");
            HasKey(d => d.Guid);
            Property(d => d.Guid).HasColumnName("Aidishka").IsRequired();
            Property(d => d.Alias).HasColumnName("Klikuha").IsRequired();
            Property(d => d.DateOfBirth).HasColumnName("DOB").HasColumnType("datetime2").IsRequired();
            Property(d => d.DogTypeId).HasColumnName("DogTypeID").IsRequired();

            Ignore(d => d.DogType);


        }
    }
}
