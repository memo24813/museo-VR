using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
// using GoogleVR.HelloVR;
public class SongInteract : MonoBehaviour
{
    // Start is called before the first frame update

        public GameObject songItem;
        protected AudioSource song;
        public Material inactiveMaterial;

        /// <summary>The material to use when this object is active (gazed at).</summary>
        public Material gazedAtMaterial;
        private Renderer myRenderer;
        public float triggerInteractionTime = 1.5f;
        public float interactionTimer = 0f;
        private bool timerRunning = false;

        private void Update() {
            if(timerRunning)
            {
                interactionTimer += Time.deltaTime;
                if(interactionTimer >triggerInteractionTime)
                {
                    // TeleportPlayer();
                    intaractVR();
                    timerRunning=false;
                }
            }    
        }
        /// <summary>Sets this instance's GazedAt state.</summary>
        /// <param name="gazedAt">
        /// Value `true` if this object is being gazed at, `false` otherwise.
        /// </param>
        public void SetGazedAt(bool gazedAt)
        {
            if(gazedAt)
            {
                timerRunning = true;
            }
            else
            {
                timerRunning = false;
                interactionTimer = 0f;
            }
            if (inactiveMaterial != null && gazedAtMaterial != null)
            {
                myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
                return;
            }
        }

        private void Start()
        {
            song = songItem.GetComponent<AudioSource>();
            myRenderer = GetComponent<Renderer>();
            SetGazedAt(false);
        }

        public virtual void intaractVR()
        {
            song.Play();
        }
    }


    // public override void intaractVR()
    // {
    //     // base.intaractVR();
    //     song.Play();
    // }
