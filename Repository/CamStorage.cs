using Repository1.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository1.Repository
{
    public class CamStorage
    {
        private readonly Dictionary<int, Cam> _Cams = new();

        public Cam Create(Cam cam)
        {

            _Cams.Add(cam.Id, cam);
            return cam;

        }

        public Cam Read(int Id)
        {
            return _Cams[Id];
        }

        public Cam Update(int Id, Cam newCam)
        {
            _Cams[Id] = newCam;
            return _Cams[Id];
        }

        public bool Delete(int Id)
        {
            return _Cams.Remove(Id);
        }
    }
}