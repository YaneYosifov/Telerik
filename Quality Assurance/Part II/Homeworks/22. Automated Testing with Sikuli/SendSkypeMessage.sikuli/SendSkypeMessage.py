#Skype should be already started and signed in
switchApp("Skype")
type("1453003482072.png", "Test Service")
click("1453003603326.png")
testServiceProfile = "1453003765105.png"
wait(testServiceProfile, 10)
click(testServiceProfile)
type("1453003957865.png", "test")
click("1453004021211.png")