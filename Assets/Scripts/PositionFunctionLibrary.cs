using UnityEngine;

public static class PositionFunctionLibrary
{
    public static Vector3 InitializePositionIn3DSpace(Vector3 position)
    { 
        position = Vector3.zero; 
        return position;
    }

    public static float GetSumOfElementInListDividedByDistanceBetweenNeigboringElementAndOffsetOfList(int elementInList, float distanceFromNeighboringElement, float offset)
    { return elementInList / distanceFromNeighboringElement + offset; }
}