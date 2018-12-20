using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

public class HaloProfile : MonoBehaviour
{

    public string Api_key = "5969689a2109180f287972a8";
    public string url = "https://www.haloapi.com/profile/h5/profiles/{player}/appearance";
    public string HaloUrl;

    public object Contract { get; private set; }

    public IEnumerator Start()
    {
        Contract.Ensures(Contract.Result<IEnumerator>() != null);

        // fetch the actual info, like you would from a browser
        WWW www = new WWW(url);

        // yield return waits for the download to complete before proceeding
        // but since this is in IEnumerator it wont stall the program outright
        yield return www;
        // use a JSON Object to store the info temporarily
        // this makes it easy to access the data struture

        //Can get parameters

        JSONObject tempData = new JSONObject(www.text);
        Debug.Log(tempData);


        // this particular API stores all the data under the header
        // "consolidated_weather" so first get in there
        string HaloDetails = tempData[0]["url"].str;
        string HaloProfile = tempData[0]["profile"].str;


        Debug.Log(HaloProfile);
        if (tempData != null)
        {
            Debug.Log(tempData[0]["profile"].ToString());
        }
        // Debug.Log(catDetails.ToString());



        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(HaloDetails))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                // Get downloaded asset bundle
                var texture = DownloadHandlerTexture.GetContent(uwr);

                Renderer renderer = GetComponent<Renderer>();
                renderer.material.mainTexture = texture;

            }
        }


        // log it just to see whats up
        //  Debug.Log (weatherDetails.ToString());

        // now we can do cool stuff like...
        //  string WeatherType = weatherDetails[0]["weather_state_name"].str;
        //  Debug.Log (WeatherType);



    }

}

