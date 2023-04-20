import './NavbarMenuStyle.css'
import { Flex } from '@adobe/react-spectrum'
import { useNavigate } from "react-router-dom";
import { useSelector, useDispatch } from 'react-redux'

const NavbarMenu = () => {

    const store = useSelector(state => state.TextSettings)
    const navigate = useNavigate()
    const dispatch = useDispatch()

    const changeTextColor = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: ['#' + randomColor, store.speed] })
    };

    const bookPageNavigate = () => {
        navigate("/books")
    }
    const homePageNavigate = () => {
        navigate("/")
    }
    const loginNavigate = () => {
        navigate("/login")
    }

    return (
        <div className="navmenu">
            <Flex direction="row" justifyContent="center" alignItems="center" height="100%">
                <div style={{ alignSelf: 'center', padding: '10% 10%' }}>
                    <Flex direction="row" justifyContent="center" alignItems="center" height="100%">
                        <p
                            style={{ color: store.textColor }}
                            onClick={homePageNavigate}
                            className="font-5vh">Stori</p>
                        <button
                            className="buttonn"
                            onClick={bookPageNavigate}
                            style={{ color: store.textColor }}
                        >Kitap</button>
                        <button
                            className="buttonn"
                            style={{ color: store.textColor }}
                        >Görsel</button>
                        <button type="button"
                            className="buttonn"
                            style={{ color: store.textColor }}
                        >Haberler</button>
                    </Flex>
                </div>
                <div style={{ marginLeft: '5%', alignSelf: 'center', padding: '0 10%' }}>
                    <button type="button"
                        className="buttonn"
                        onClick={changeTextColor}
                        style={{ color: store.textColor }}
                    >Renk</button>
                    <button type="button"
                        className="buttonn"
                        onClick={loginNavigate }
                        style={{ color: store.textColor }}
                    >Giriş</button>
                </div>
            </Flex>
        </div>
    );
}

export default NavbarMenu