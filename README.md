# Load Test on DC Shunt Motor - Virtual Reality Simulation

An immersive Virtual Reality (VR) electrical engineering laboratory simulation for conducting a **Load Test on a DC Shunt Motor**.

Built with **Unity**, **XR Interaction Toolkit (XRI)**, and **OpenXR** (Meta Quest / PCVR support).

---

## 📌 Project Overview

This XR application allows students and researchers to perform the Load Test experiment on a DC Shunt Motor in a safe, interactive virtual laboratory environment. Users can:
- Wire connections between components (3-point starter, DC shunt motor, field rheostat, ammeter, voltmeter, load bank / brake drum).
- Interact using VR controllers (grab wires, connect terminals, adjust starter sliders).
- Observe motor rotation, shaft speed, meters, and performance under varying mechanical/electrical loads.

---

## 🚀 Key Features

- **Interactive Circuit Wiring**: Dynamic node connection and wire manager (`CircuitManager.cs`, `WireManager.cs`, `Connection.cs`, `LabNode.cs`).
- **VR Interaction**: Custom VR node selection and physical 3D interactions powered by Unity XR Interaction Toolkit (`VRNodeSelector.cs`, `StarterSlider.cs`).
- **Motor Dynamics**: Dynamic shaft rotation and mechanical animation responding to operating conditions (`MotorRotate.cs`, `RotateShaft.cs`).
- **Multi-Scene Support**: Includes dedicated laboratory setups (`Lab.unity`, `all_objects.unity`, `DemoScene.unity`).

---

## 🛠️ Tech Stack & Requirements

- **Engine**: Unity (XR Interaction Toolkit, OpenXR / Oculus XR plugin)
- **Target Platforms**: Meta Quest (Android APK), PCVR (OpenXR compatible headsets)
- **Language**: C#

---

## 📂 Project Structure

```
LoadTestOnDCShuntMotor/
├── Assets/
│   ├── Scripts/            # Core logic (CircuitManager, WireManager, MotorRotate, etc.)
│   ├── Scenes/             # Lab and experiment scenes (Lab.unity, etc.)
│   ├── XR/                 # OpenXR & Oculus loader and provider configurations
│   └── VRTemplateAssets/   # Interaction affordances, UI, and audio themes
├── Packages/               # Unity Package Manager manifest & lockfile
├── ProjectSettings/        # Input, graphics, OpenXR, and player settings
└── .gitignore              # Standard Unity Git ignore configuration
```

---

## ⚙️ Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/TanushriSV/DC-Shunt-Motor.git
   ```
2. Open **Unity Hub**.
3. Click **Add** -> **Add project from disk** and select the repository root folder.
4. Ensure the required Unity Editor version and Android/XR build support modules are installed.
5. Open the project and navigate to `Assets/Scenes/Lab.unity` to begin.
