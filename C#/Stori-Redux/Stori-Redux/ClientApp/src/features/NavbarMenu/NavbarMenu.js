import './NavbarMenuStyle.css'
import React, { useState } from "react";
import { useDispatch } from 'react-redux'

const NavbarMenu = () => {

    // Redux Store da tutulacak textColor değeri için state ayarı
    // Dispatch ile değişikliği store a kaydedecek
    const [textColor, setTextColor] = useState(null)
    const textDispatch = useDispatch()


    return (
        <div className="navmenu">
            <div className="w-1/6 bg-white">
                <p>
                    Stori
                </p>
            </div>
        </div>
    );
}

export default NavbarMenu