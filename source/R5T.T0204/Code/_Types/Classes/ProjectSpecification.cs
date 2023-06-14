using System;

using R5T.T0142;
using R5T.T0187;


namespace R5T.T0204
{
    [DataTypeMarker]
    public class ProjectSpecification : IProjectSpecification
    {
        public IProjectName ProjectName { get; set; }
        public IProjectDescription ProjectDescription { get; set; }
    }
}
