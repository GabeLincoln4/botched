using UnityEngine;

public static class ComparisonFunctionLibrary
{ 
    public static bool AssertThatPrimaryTransformIsEqualToSecondaryTransform(Transform primaryTransform, Transform secondaryTransform)
    { 
        if (primaryTransform == secondaryTransform)
        { return true; }
        else 
        { return false; }
    }
}