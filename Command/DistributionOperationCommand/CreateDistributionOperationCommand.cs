﻿using MediatR;

namespace ElkoodTask.Command.DistributionOperationCommand;

public class CreateDistributionOperationCommand : IRequest<DistributionOperation>
{
    public int PrimaryBranchInfoId { get; set; }
    public int SecondaryBranchInfoId { get; set; }
    public int ProductInfoId { get; set; }
    public int quantity { get; set; }
    public DateTime date { get; set; }
}