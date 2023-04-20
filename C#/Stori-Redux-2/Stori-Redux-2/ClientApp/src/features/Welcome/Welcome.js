import './WelcomeStyle.css'
import { Flex } from '@adobe/react-spectrum'
import { useNavigate } from "react-router-dom";
import { useSelector, useDispatch } from 'react-redux'

const Welcome = () => {

    const store = useSelector(state => state.TextSettings)
    const navigate = useNavigate()
    const dispatch = useDispatch()

    return (
        <Flex>
            <div style={{ margin: 'auto', alignSelf: 'center', marginStart: '16px', display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
                <h1 style={{ color: store.textColor }}>Hoşgeldiniz</h1>
            </div>
        </Flex>
        
        
    )
}

export default Welcome