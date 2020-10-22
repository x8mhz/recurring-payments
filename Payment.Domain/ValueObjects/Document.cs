using Payment.Domain.Enums;

namespace Payment.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType eDocumentType)
        {
            Number = number;
            EDocumentType = eDocumentType;
        }

        public string Number { get; private set; }
        public EDocumentType EDocumentType { get; private set; }

        private bool Validate()
        {
            if (EDocumentType == EDocumentType.Cnpj && Number.Length == 14) 
                return true;

            if (EDocumentType == EDocumentType.Cpf && Number.Length == 11) 
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"{Number}";
        }
    }
}