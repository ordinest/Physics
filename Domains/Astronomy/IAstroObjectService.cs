using Asterism;

namespace Physics.Domains.Astronomy
{
    public interface IAstroObjectService
    {
        public Task<IEnumerable<AstroObject>> GetAll();
        public Task<IEnumerable<AstroObject>> GetObjectsInRegion(EquitorialCoords minCoords, EquitorialCoords maxCoords);
    }
}
