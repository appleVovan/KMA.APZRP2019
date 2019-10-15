using System;
using System.Runtime.Serialization;

namespace KMA.APZRP2019.WalletSimulator.DBModels
{
    public enum DogType
    {
        Dvornyaga = 0,
        Labrador = 1,
        Pudel = 2,
        Labradudel = 3
    }
    [DataContract(IsReference = true)]
    public class Dog
    {
        [DataMember]
        private Guid _guid;
        [DataMember]
        private string _alias;
        [DataMember]
        private DogType _dogType;
        [DataMember]
        private DateTime _dateOfBirth;
        [DataMember]
        private Guid _ownerGuid;
        [DataMember]
        private User _owner;


        public Guid Guid
        {
            get => _guid;
            set => _guid = value;
        }

        public string Alias
        {
            get => _alias;
            set => _alias = value;
        }

        public DogType DogType
        {
            get => _dogType;
            set => _dogType = value;
        }

        public int DogTypeId
        {
            get => (int)_dogType;
            set => _dogType = (DogType)value;
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public virtual User Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public Guid OwnerGuid
        {
            get => _ownerGuid;
            set => _ownerGuid = value;
        }

        public Dog(string alias):this()
        {
            _guid = Guid.NewGuid();
            _alias = alias;
            _dateOfBirth = DateTime.Today;
            _dogType = DogType.Labradudel;
        }

        public Dog()
        {

        }
    }
}
