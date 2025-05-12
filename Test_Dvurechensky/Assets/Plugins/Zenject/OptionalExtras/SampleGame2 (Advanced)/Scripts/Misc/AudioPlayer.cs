/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using UnityEngine;

namespace Zenject.SpaceFighter
{
    public class AudioPlayer
    {
        readonly Camera _camera;

        public AudioPlayer(Camera camera)
        {
            _camera = camera;
        }

        public void Play(AudioClip clip)
        {
            Play(clip, 1);
        }

        public void Play(AudioClip clip, float volume)
        {
            _camera.GetComponent<AudioSource>().PlayOneShot(clip, volume);
        }
    }
}
