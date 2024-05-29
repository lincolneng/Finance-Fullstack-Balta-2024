using Finance.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Core.Requests.Transactions;

public class UpdateTransactionRequest
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Titulo Invalido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Invalido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Valor Invalido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria Invalida")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data Invalida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
