<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:000000,30:0a0a2e,70:1a1a4e,100:0d0d3b&height=220&section=header&text=Planets%20AR&fontSize=60&fontColor=ffffff&fontAlignY=38&desc=A%20Guide%20to%20Our%20Solar%20System%20%7C%20Unity%20AR%20Uygulaması&descAlignY=60&descSize=16&animation=fadeIn" width="100%"/>

<br/>

[![Unity](https://img.shields.io/badge/Unity-2022.3.62f3-black?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/)
[![AR Foundation](https://img.shields.io/badge/AR%20Foundation-5.2.0-00C4CC?style=for-the-badge&logo=unity&logoColor=white)](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.2/manual/index.html)
[![Android](https://img.shields.io/badge/Android-Platform-3DDC84?style=for-the-badge&logo=android&logoColor=white)](https://developer.android.com/)
[![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)

<br/>


</div>

---

##  Proje Hakkında

**Planets AR**, Unity ve AR Foundation kullanılarak geliştirilen bir **Artırılmış Gerçeklik (AR)** mobil uygulamasıdır. Kullanıcılar ana menüden bir gezegen seçerek onun gerçek zamanlı 3D modelini ve dönüş animasyonunu izleyebilir. Galaxy modunda ise tüm gezegenlerin Güneş etrafındaki yörünge hareketleri simüle edilmektedir.

---

##  Özellikler

-  **8 Gezegen + Galaxy** — Earth, Mars, Jupiter, Mercury, Neptune, Saturn, Uranus, Venus
-  **3D Dönüş Animasyonları** — Her gezegenin kendi ekseni etrafındaki rotasyonu
-  **Galaxy Modu** — Gezegenlerin Güneş etrafındaki yörünge hareketleri *(özel eklenti)*
-  **Android Uyumlu** — Redmi 9 (1080x2400) ve üzeri cihazlarda test edildi
-  **Buton Tabanlı Navigasyon** — Sezgisel ana ekran menüsü

---

##  Kurulum & Çalıştırma

### Gereksinimler

| Araç | Sürüm |
|------|-------|
| Unity | 2022.3.62f3 |
| AR Foundation | 5.2.0 |
| Android Build Support | Unity ile birlikte |
| Android Cihaz | AR Core destekli |

### Adım Adım

**1. Repoyu klonla:**
```bash
git clone https://github.com/gizemezer/MyUnityGame.git
cd MyUnityGame
```

**2. Unity'de aç:**
- Unity Hub'ı aç
- `Add Project` → klonladığın klasörü seç
- Unity 2022.3.62f3 ile aç

**3. Sahneyi aç:**
```
Assets
  └── Scenes
        └── HomeScreen  ← Ana menü sahnesi
```

**4. Android Build:**
- `File` → `Build Settings` → `Android` seç
- `Switch Platform` → `Build & Run`

---

## 🗂️ Sahne Yapısı

```
MyUnityGame/
├── 📁 Assets/
│   └── 📁 Scenes/
│       ├── 🏠 HomeScreen     ← Ana menü (gezegen butonları)
│       ├── 🌍 Earth          ← Dünya sahnesi
│       ├── 🔴 Mars           ← Mars sahnesi
│       ├── 🪐 Jupiter        ← Jüpiter sahnesi
│       ├── ⚫ Mercury        ← Merkür sahnesi
│       ├── 🔵 Neptune        ← Neptün sahnesi
│       ├── 💍 Saturn         ← Satürn sahnesi
│       ├── 🩵 Uranus         ← Uranüs sahnesi
│       ├── 🟠 Venus          ← Venüs sahnesi
│       └── 🌌 Galaxy         ← Güneş sistemi yörünge sahnesi
├── 📁 Packages/
├── 📁 ProjectSettings/
└── 📄 README.md
```

---

##  Nasıl Çalışır?

```
Ana Menü (HomeScreen)
        ↓
   Gezegen Seçimi
        ↓
  ┌─────────────────────────────┐
  │  Gezegen Sahnesi            │  → 3D model + kendi ekseni dönüşü
  │  Galaxy Sahnesi             │  → Güneş etrafında yörünge hareketi 
  └─────────────────────────────┘
        ↓
   "Back" butonu ile geri dön
```

**Galaxy Modu** projeye sonradan eklenen özel bir özelliktir. Güneş merkeze yerleştirilmiş, gezegenler farklı yörünge hızlarıyla etrafında döndürülmüştür.

---

## Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|-----------|---------------|
| **Unity 2022.3** | Oyun motoru ve render |
| **AR Foundation 5.2** | Artırılmış gerçeklik altyapısı |
| **C#** | Sahne geçişleri ve animasyon scriptleri |
| **Android XR** | Mobil AR desteği |
| **ShaderLab / HLSL** | Gezegen shader'ları ve görsel efektler |

---

##  İlham Kaynağı

Bu proje, aşağıdaki YouTube eğitiminden ilham alınarak geliştirilmiştir:

▶️ [Unity AR Planets Tutorial](https://www.youtube.com/watch?v=FJAO6jDYljs&t=877s)

> **Galaxy yörünge modu** bu projeye özgün olarak eklenmiştir. 

---

## Geliştirici

<div align="center">

**Gizem Ezer**

[![GitHub](https://img.shields.io/badge/GitHub-gizemezer-181717?style=for-the-badge&logo=github)](https://github.com/gizemezer)

</div>

---

## 📌 Notlar

- Uygulama **AR Core destekli Android** cihazlarda çalışır.
- Unity editöründe çalıştırıldığında AR uyarıları normal görünebilir, gerçek cihazda sorunsuz çalışır.
- Galaxy sahnesindeki yörünge hızları gerçek astronomik oranlardan esinlenilmiştir.

---

<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0d0d3b,50:1a1a4e,100:000000&height=120&section=footer" width="100%"/>



</div>
