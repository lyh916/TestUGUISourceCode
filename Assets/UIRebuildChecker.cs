#define CheckUIRebuild

using UnityEngine.UI;
using UnityEngine;

public class UIRebuildChecker : MonoBehaviour
{
#if CheckUIRebuild
    public bool isLog = false;

    private void Awake()
    {
        CanvasUpdateRegistry.instance.rebuildEvent += Check;
    }

    private Canvas GetCanvas(Transform tra, ref int i)
    {
        Canvas can = tra.GetComponent<Canvas>();
        if (can == null)
        {
            i++;
            return GetCanvas(tra.parent, ref i);
        }
        return can;
    }

    public void Check(ICanvasElement canvasElement, UIRebuildType rebuildType)
    {
        Transform tra = canvasElement.transform;
        GameObject go = tra.gameObject;
        int depth = 0;
        Canvas can = GetCanvas(tra, ref depth);

        if (Application.isPlaying)
        {
            string str;
            if (rebuildType == UIRebuildType.LayoutRebuild)
            {
                str = "(LayoutRebuild){0}:{1},depth:{2}";
            }
            else
            {
                str = "(GraphicRebuild){0}:{1},depth:{2}";
            }
            if (isLog)
            {
                Debug.LogErrorFormat(tra, str, can.name, go.name, depth);
            }
        }
    }
#endif
}