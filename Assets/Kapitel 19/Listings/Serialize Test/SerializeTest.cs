using System.Collections.Generic;
using UnityEngine;

public class SerializeTest : MonoBehaviour
{
    [SerializeField] private DataStruct dataStruct;
    [SerializeField] private List<DataStruct> dataStructList;
}