using System;

using R5T.T0142;
using R5T.T0187;


namespace R5T.T0204
{
    [DataTypeMarker]
    public interface IProjectSpecification
    {
        IProjectName ProjectName { get; }
        IProjectDescription ProjectDescription { get; }
    }
}
