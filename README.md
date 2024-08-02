# LLM-TabHotInputs
<sub>Have you tried to press TAB when its 2 or more fields to quickly swap between them but you just getting annoyed cause nothing happening? Fear no more! That plugin does that, supports new InputSystem and old one as well!</sub>

### Ok but how to actually use it?
> Default extension requires TMP (TextMeshPro) packet but you can re-write to your own fields.

<br></br>

1.&nbsp;Clone repo to your assets
> git clone https://github.com/limelight-mint/LLM-TabHotInputs.git

2.&nbsp;If you seeing this error, thats fine, delete the folder you dont need (either `TabSystem/NewInputSystem` or `TabSystem/OldInputSystem`). If you dont know what it means, use the Old one and delete the New one!

![New Input System Error Pic](https://bunbun.cloud/assets/images/git/error.png)

3.&nbsp;Drag n drop script `TabSystem/{YourInput}/TabSystem{yourInput}.cs` whenever you like (usually a parent or a canvas) and drag-n-drop fields that will be swappable:

![Swappable Inputs Pic](https://bunbun.cloud/assets/images/git/tmp_hotswap.png)

> [!TIP]
> You can change a button (it can be not only TAB but any button like Joystic button or Keypad)

<br></br>

> [!NOTE]
> If you want to make a custom swap you can inherit `TabSystemBase.cs` and re-write some logic
