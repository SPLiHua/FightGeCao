using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptableObject/PathConfig")]
public class PathConfig : ScriptableObject
{
	[SerializeField]
	public List<SaveSetting> saveSettingList;

	private static PathConfig instance;
	public static PathConfig Instance
	{
		get
		{
			if (instance == null)
			{
				UnityEngine.Object obj = Resources.Load("Config/PathConfig");
				if (obj != null)
				{
					instance = obj as PathConfig;
				}
			}
			return instance;
		}
	}

	public SaveSetting GetSaveSettingPath(string name, out int index)
	{
		index = -1;
		for (int i = 0; i < saveSettingList.Count; i++)
		{
			if (saveSettingList[i].Name == name)
			{
				index = i;
				return saveSettingList[i];
			}
		}
		return null;
	}
}
