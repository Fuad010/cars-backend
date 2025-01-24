import { NavLink } from "react-router-dom"
import styles from './yellowButton.module.css'

export const YellowButton = () => {
    return (
        <NavLink className={styles.yellowButton} to={"/"}>
            Go to dashboard
        </NavLink>
    )
}