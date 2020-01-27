using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
namespace Vuforia
{
	public class targetData : MonoBehaviour
	{
		public Transform TextTargetName;
		public Transform TextDescription;
		public Transform PanelDescription;

		// Use this for initialization
		void Start()
		{
			//add Audio Source as new game object component
		}
		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();
				Debug.Log("Active image target:" + name + " -size: " + size.x + ", "
					+ size.y);
				//Evertime the target found it will show “name of target” on the
				//TextTargetName. Button, Description and Panel will visible (active)
				TextTargetName.GetComponent<Text>().text = name;
				TextDescription.gameObject.SetActive(true);
				PanelDescription.gameObject.SetActive(true);
				//If the target name was “zombie” then add listener to ButtonAction
				//with location of the zombie sound (locate in Resources/sounds folder)
				//and set text on TextDescription a description of the zombie
				if(name == "Napa"){
					
					TextDescription.GetComponent<Text>().text = "What Napa® is and what it is used for?\n\n" +
						"Napa® (Paracetamol) is a fast acting and safe analgesic with marked antipyretic property." +
						"\n\nIt is recommended for the treatment of most painful and febrile conditions, such as headache, toothache, " +
						"backache, rheumatic and muscle pains, dysmenorrhoea, sore throat, and for relieving the fever, aches and pains" +
						" of colds and flu.\n\nHow to take Napa®\n\nTablet:\nAdults: 1-2 tablets 3-4 times daily\n\nSyrup/Suspension:\n" +
						"Adults: 4-8 Measuring spoonful 3-4 times daily;\nChildren: 6-12 years: 2- 4 measuring spoonful 3-4 times daily," +
						" 1-5 years: 1-2 Measuring spoonful 3-4 times daily, Up to 1 year: 1/2 -1 Measuring spoonful 3-4 times daily\n\n" +
						" How to store Napa®\nStore in a cool and dry place, away from light. Keep out of the reach and sight of children.";
				}
				else if (name == "HPRds")
				{
					TextDescription.GetComponent<Text>().text = "What is Hpr-Ds?\n" +
						"Hpr-Ds Tablet is used for Pain during periods, Heavy bleeding during periods, Fever, " +
						"Migraine headache, Analgesic, Inflammation and other conditions.\n" + 
						"Precautions & How to Use\n\n" +
						"Before using Hpr-Ds Tablet, inform your doctor about your current list of medications," +
						" over the counter products (e.g. vitamins, herbal supplements, etc.), allergies, pre-existing diseases," +
						" and current health conditions (e.g. pregnancy, upcoming surgery, etc.). Some health conditions may make you " +
						"more susceptible to the side-effects of the drug. Take as directed by your doctor or follow the direction printed" +
						" on the product insert. Dosage is based on your condition. Tell your doctor if your condition persists or worsens. " +
						"Important counseling points are listed below.\nHave renal and hepatic impairment\nTaking prescription or " +
						"nonprescription medicines";
				}
				else if (name == "NapaExtend")
				{
					TextDescription.GetComponent<Text>().text = " What Napa Extend  is and what it is used for?\n\n" +
						"Paracetamol 665 mg Extended Release tablet is effective for the relief of persistent pain associated " +
						"with osteoarthritis and muscle aches and pains such as backache. Paracetamol 665 mg Extended Release tablet " +
						"also provides effective, temporary relief of pain and discomfort associated with headache," +
						" tension headache, period pain, toothache and pain after dental procedures, and cold & flu. Reduces fever." +
						" \n\n How to take Napa Extend\n\nParacetamol 665 mg Extended Release tablet are to be administered " +
						"orally, with or without food. Adults and children over 12 years. Two tablets, swallowed whole, every 6 to 8 hours" +
						" (maximum of 6 tablets in any 24 hours). " +"The tablets must not be crushed.";
				}
				else if (name == "Entacyd_Plus")
				{
					TextDescription.GetComponent<Text>().text = " What is Entacyd Plus?\n\n" +
						"Entacyd Plus Suspension is used for Painful pressure, Acid indigestion, Stomach upset, Heartburn, Stomach acid," +
						" Increases water in the intestines and other conditions. Entacyd Plus Suspension may also be used for purposes not " +
						"listed in this medication guide.";
				}
			}
		}

	}
}