using System;

using R5T.T0187;


namespace R5T.T0204
{
    public interface IProjectSpecification
    {
        IProjectName ProjectName { get; }
        IProjectDescription ProjectDescription { get; }
    }
}
