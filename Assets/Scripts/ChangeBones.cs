using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBones : MonoBehaviour
{
    GameObject body;


    void Start()
    {
        body = GameObject.Find("characterBody");
        SkinnedMeshRenderer[] bodyRenderers =
        body.GetComponentsInChildren<SkinnedMeshRenderer>();

        Dictionary<string, Transform> boneMap =
        new Dictionary<string, Transform>();

        foreach (SkinnedMeshRenderer renderer in bodyRenderers)
        {
            foreach (Transform bone in renderer.bones)
            {
                if (!boneMap.ContainsKey(bone.name))
                {
                    boneMap[bone.name] = bone;
                }
            }
        }

        SkinnedMeshRenderer[] renderers =
    GetComponentsInChildren<SkinnedMeshRenderer>();

        foreach (SkinnedMeshRenderer renderer in renderers)
        {
            Transform[] boneArray = renderer.bones;

            for (int idx = 0; idx < boneArray.Length; ++idx)
            {
                string boneName = boneArray[idx].name;

                if (boneMap.TryGetValue(boneName, out Transform mappedBone))
                {
                    boneArray[idx] = mappedBone;
                }
                else
                {
                    Debug.LogWarning("failed to get bone: " + boneName);
                }
            }

            renderer.rootBone = body.transform.Find("Armature.001/Hips");

            renderer.bones = boneArray;
        }
    }

    void Update()
    {

    }
}
