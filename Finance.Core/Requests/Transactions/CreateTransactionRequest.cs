using Finance.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Titulo Invalido")]
    public string Title{ get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Invalido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Valor Invalido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria Invalida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data Invalida")]
    public DateTime? PaidOrReceivedAt{ get; set; }

}

