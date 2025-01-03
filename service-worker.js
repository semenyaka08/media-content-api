/**
 * Welcome to your Workbox-powered service worker!
 *
 * You'll need to register this file in your web app and you should
 * disable HTTP caching for this file too.
 * See https://goo.gl/nhQhGp
 *
 * The rest of the code is auto-generated. Please don't update this file
 * directly; instead, make changes to your Workbox build configuration
 * and re-run your build process.
 * See https://goo.gl/2aRDsh
 */

importScripts("https://storage.googleapis.com/workbox-cdn/releases/4.3.1/workbox-sw.js");

self.addEventListener('message', (event) => {
  if (event.data && event.data.type === 'SKIP_WAITING') {
    self.skipWaiting();
  }
});

/**
 * The workboxSW.precacheAndRoute() method efficiently caches and responds to
 * requests for URLs in the manifest.
 * See https://goo.gl/S9QRab
 */
self.__precacheManifest = [
  {
    "url": "404.html",
    "revision": "9533cba846a8e6a81c1eb273b3f794ee"
  },
  {
    "url": "assets/css/0.styles.169a5b3d.css",
    "revision": "fdd057c510a0d6562f78205f63b4d380"
  },
  {
    "url": "assets/img/content-ContentNotFoundException.1cac2d6d.jpg",
    "revision": "1cac2d6d8ced91552cb6a9df9f9f97a0"
  },
  {
    "url": "assets/img/delete-content.9b628707.jpg",
    "revision": "9b628707e1da6343101438c2e1bcbfd6"
  },
  {
    "url": "assets/img/delete-user.284e3588.jpg",
    "revision": "284e35889138049c73b2108ca617e027"
  },
  {
    "url": "assets/img/get-content.0ad3b483.jpg",
    "revision": "0ad3b483649ddbe7300e9c5587d56f3f"
  },
  {
    "url": "assets/img/get-contents.8cefb0e4.jpg",
    "revision": "8cefb0e4184a7858fb09e621cec8ba3c"
  },
  {
    "url": "assets/img/get-user.b673a1be.jpg",
    "revision": "b673a1bec5667a4576f31a187c02339c"
  },
  {
    "url": "assets/img/get-users.b673a1be.jpg",
    "revision": "b673a1bec5667a4576f31a187c02339c"
  },
  {
    "url": "assets/img/post-content.3a638d26.jpg",
    "revision": "3a638d26075b4da8d3796e45ba5ad86b"
  },
  {
    "url": "assets/img/post-user.da0c2668.jpg",
    "revision": "da0c26687172bed49583aa66985e8b3d"
  },
  {
    "url": "assets/img/put-content.ffbed462.jpg",
    "revision": "ffbed462cb4ff235435fc2ea383c824a"
  },
  {
    "url": "assets/img/put-user.eb3e2e3b.jpg",
    "revision": "eb3e2e3b6357251e8f9822e91df430e0"
  },
  {
    "url": "assets/img/relational_schema.ce95178e.png",
    "revision": "ce95178e03036cd4d2d2ffe1a92aaba3"
  },
  {
    "url": "assets/img/search.83621669.svg",
    "revision": "83621669651b9a3d4bf64d1a670ad856"
  },
  {
    "url": "assets/img/user-EmailNotValid.325b91d9.jpg",
    "revision": "325b91d9938e9d36efeadeff47fc1546"
  },
  {
    "url": "assets/img/user-UserNotFoundException.00f6f5e2.jpg",
    "revision": "00f6f5e2278d568325e6643349eeab96"
  },
  {
    "url": "assets/js/10.b59ca781.js",
    "revision": "39e29111f52c370d1a137ef9eefbef25"
  },
  {
    "url": "assets/js/11.33205cae.js",
    "revision": "369ae883b30bd84e6e1faf9568fe1154"
  },
  {
    "url": "assets/js/12.4e9ed508.js",
    "revision": "db7d0cc577360eac9445145fa10f73d6"
  },
  {
    "url": "assets/js/13.79616cd0.js",
    "revision": "f9b759a9b949e2326527e7be0315715a"
  },
  {
    "url": "assets/js/14.3abf31d7.js",
    "revision": "9ba942219a6b61e8fbf4816af109e69d"
  },
  {
    "url": "assets/js/15.be6aa669.js",
    "revision": "9994b92a569fab6fd9f033574f2c1c72"
  },
  {
    "url": "assets/js/16.ad973f94.js",
    "revision": "930fa9523866e1be3757cd2cb37bda93"
  },
  {
    "url": "assets/js/17.c03a7d38.js",
    "revision": "ad70c37b7293c18803903399b39c6b42"
  },
  {
    "url": "assets/js/18.f65a78ca.js",
    "revision": "02bbc519028da38710fdafa73530582c"
  },
  {
    "url": "assets/js/19.654a7dd0.js",
    "revision": "a1148a851d4b5aac5cfddeed2665dd03"
  },
  {
    "url": "assets/js/2.b2d72a20.js",
    "revision": "81fc9dd33e3a32687c0916a06dd44499"
  },
  {
    "url": "assets/js/20.92d88311.js",
    "revision": "1261d7fa77120af44362ed18941905e8"
  },
  {
    "url": "assets/js/21.622e7703.js",
    "revision": "812c5875bd4cdabfc408d21fd73c30dc"
  },
  {
    "url": "assets/js/22.d265011b.js",
    "revision": "943f0f591420d9346a9dab0c035dee16"
  },
  {
    "url": "assets/js/23.eb794c97.js",
    "revision": "9c5948485f164c2e218da8f664cf56f7"
  },
  {
    "url": "assets/js/24.ff1ecde9.js",
    "revision": "d7421e052e39d050d0cd32a4274f1eb8"
  },
  {
    "url": "assets/js/26.9c6c8ef1.js",
    "revision": "4fa089712c0ae80f2d15b533a7984b9e"
  },
  {
    "url": "assets/js/3.dbed276c.js",
    "revision": "161043aab5c593d550195c2ed53a94f3"
  },
  {
    "url": "assets/js/4.c60a31fc.js",
    "revision": "6832a823208970a0cee82afea146afc6"
  },
  {
    "url": "assets/js/5.4698dad1.js",
    "revision": "bc0ff595b846299e03939565cf152d3f"
  },
  {
    "url": "assets/js/6.e0bfc8f5.js",
    "revision": "7b225eb5f151d8710bbe3eec9b33f75d"
  },
  {
    "url": "assets/js/7.450784fd.js",
    "revision": "55d70d6d70d0fc997b262b9c8f2e0fd9"
  },
  {
    "url": "assets/js/8.f5843999.js",
    "revision": "c855dc6eef094e92aca884d8b93a8fd5"
  },
  {
    "url": "assets/js/9.c112129d.js",
    "revision": "dca8aca7a23065518a2d2405b4cb3788"
  },
  {
    "url": "assets/js/app.69e121f7.js",
    "revision": "3798eb76753b87004e0d254f53e00487"
  },
  {
    "url": "conclusion/index.html",
    "revision": "1cfbe8ea734446d727ee4e457cd5d3e1"
  },
  {
    "url": "design/index.html",
    "revision": "dc5f1ee13c47c5a77256466b5beb568b"
  },
  {
    "url": "index.html",
    "revision": "9c0fd1c705e5414c1819dea368244c76"
  },
  {
    "url": "intro/index.html",
    "revision": "bf38050b2b69fee51d2360e1e8695fd3"
  },
  {
    "url": "license.html",
    "revision": "70a2edbdcd1a16b29dc6ec11e14ab937"
  },
  {
    "url": "myAvatar.png",
    "revision": "b76db1e62eb8e7fca02a487eb3eac10c"
  },
  {
    "url": "requirements/index.html",
    "revision": "20d3db476266da0e4dc43a478c9567d0"
  },
  {
    "url": "requirements/stakeholders-needs.html",
    "revision": "af6d6e54a119ee15d2504e7c64571ee1"
  },
  {
    "url": "requirements/state-of-the-art.html",
    "revision": "7530df64ac889085ce0140adc4c0f4b9"
  },
  {
    "url": "software/index.html",
    "revision": "69f4dfe4968df507c0efb09e9dededc0"
  },
  {
    "url": "test/index.html",
    "revision": "29b622c8a2e87d60727ccf72bfa0a172"
  },
  {
    "url": "use cases/index.html",
    "revision": "245be918cfefec8c2e9f9ec986a47aa9"
  }
].concat(self.__precacheManifest || []);
workbox.precaching.precacheAndRoute(self.__precacheManifest, {});
addEventListener('message', event => {
  const replyPort = event.ports[0]
  const message = event.data
  if (replyPort && message && message.type === 'skip-waiting') {
    event.waitUntil(
      self.skipWaiting().then(
        () => replyPort.postMessage({ error: null }),
        error => replyPort.postMessage({ error })
      )
    )
  }
})
