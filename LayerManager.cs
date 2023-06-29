using UnityEngine;

namespace JustGame.Scripts.Managers
{
    public static class LayerManager
    {
        #region Layers
		//Example
        //public static int WaterLayer = 4;
		//public static int WallLayer = 4;
		
		#endregion
		
        #region Layer Masks
		//Example
        //public static int WaterMask = 1 << WaterLayer;
        //public static int WallMask = 1 << WallLayer;
        //public static int BlockingMask = WaterMask | WallMask
		
        #endregion
        
        
        public static bool IsInLayerMask(int layerWantToCheck, LayerMask layerMask)
        {
            if (((1 << layerWantToCheck) & layerMask) != 0)
            {
                return true;
            }
            return false;
        }
    }

}
