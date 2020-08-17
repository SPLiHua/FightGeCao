using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DataHandler<T> where T : new()
{
	public IDataWriter<T> m_DataWriter;
	public IDataReader<T> m_DataReader;
	public T m_Data;
	public SaveSetting m_SaveSetting;

	public DataHandler()
	{
		m_Data = new T();
		m_SaveSetting = new SaveSetting(m_Data.GetType().Name + "SaveSetting");
	}

	public virtual void Write()
	{
		m_DataWriter.Write(m_Data, string.Format("{0}/{1}.json", m_SaveSetting.DataPath, m_Data.GetType().Name));
	}

	public virtual bool Read()
	{
		int index;
		SaveSetting temp = PathConfig.Instance.GetSaveSettingPath(m_SaveSetting.Name, out index);
		if (temp != null)
		{
			m_SaveSetting = temp;
		}
		else
		{
			PathConfig.Instance.saveSettingList.Add(m_SaveSetting);
		}
		return m_DataReader.Read(ref m_Data, string.Format("{0}/{1}.json", m_SaveSetting.DataPath, m_Data.GetType().Name));
	}

	public void SetSaveSetting(SaveSetting saveSetting)
	{
		m_SaveSetting = saveSetting;
		int index;
		SaveSetting temp = PathConfig.Instance.GetSaveSettingPath(m_SaveSetting.Name, out index);
		if (temp != null)
		{
			PathConfig.Instance.saveSettingList[index] = m_SaveSetting;
		}
		else
			PathConfig.Instance.saveSettingList.Add(m_SaveSetting);
	}

	public virtual void LoadFinish()
	{

	}
}
