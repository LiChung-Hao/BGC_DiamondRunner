using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySetting : MonoBehaviour
{
    public void CasualDifficulty()
    {
        GameManager.casual = true;
    }

    public void SkillfulDifficulty()
    {
        GameManager.casual = false;
    }
}
