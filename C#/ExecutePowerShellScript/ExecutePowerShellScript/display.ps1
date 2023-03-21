$networkName = "Screen_Mirroring-4DF116"

# Use the netsh command to add a new wireless profile for the network
# netsh wlan add profile filename="$($networkName).xml"

# # Set the network profile settings
# $wifiProfile = netsh wlan show profiles name="$($networkName)" key=clear
# $wifiProfile = $wifiProfile -match "Key Content.*" | Out-String
# $wifiProfile = $wifiProfile.Replace("Key Content            : ", "")
# $wifiProfile = $wifiProfile.Trim()
# $wifiProfile = $wifiProfile -replace '\s',''

if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "User")) { Start-Process powershell.exe "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`"" -Verb RunAs; exit }

$code = @"
    [DllImport("user32.dll")]
    public static extern bool BlockInput(bool fBlockIt);
"@

$userInput = Add-Type -MemberDefinition $code -Name UserInput -Namespace UserInput -PassThru

function Disable-UserInput($seconds) {
    $userInput::BlockInput($true)
    $ssid = (netsh wlan show interfaces | select-string 'SSID\s+:\s(\w+)')
    if($ssid)
    {
        $ssid = $ssid.Matches.Groups[1].Value
        netsh wlan disconnect
    }
    
    netsh wlan connect name="$($networkName)" ssid="$($networkName)"


    Add-Type -assembly System.Windows.Forms

    $main_form = New-Object System.Windows.Forms.Form
    $main_form.Text = "Ekrana Baglaniliyor"
    $main_form.Width=600
    $main_form.Height=400
    $main_form.AutoSize = $true
    


    $wshell = New-Object -ComObject wscript.shell;
    explorer.exe ms-settings-connectabledevices:devicediscovery 
    Start-Sleep(2)
    $userInput::BlockInput($false)
    $wshell.SendKeys("{Enter}")
    $wshell.SendKeys("Screen_Mirroring-4DF116")
    $userInput::BlockInput($true)
    Start-Sleep(1)
    $userInput::BlockInput($false)
    $wshell.SendKeys("{Tab}")
    $wshell.SendKeys("{Enter}")
    $wshell.SendKeys("{Esc}")

    $main_form.ShowDialog()
    
    $ssidscreen = (netsh wlan show interfaces | select-string 'ssid\s+:\s(\w+)')
    if($ssidscreen)
    {
        netsh wlan disconnect
    }
    if($ssid)
    {
         netsh wlan connect name=$ssid ssid=$ssid
    }
    
}

Disable-UserInput -seconds 5 | Out-Null


