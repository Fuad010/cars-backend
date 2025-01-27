import { NavLink } from "react-router-dom"
import styles from './yellowButton.module.css'
import { useLocation } from "react-router-dom"

export const YellowButton = () => {
    const location = useLocation();
    const isDashboardPage = location.pathname.includes(`/dashboard`);

    return (
        <>
            {!isDashboardPage &&
                <NavLink className={styles.yellowButton} to={"/dashboard"}>
                    Go to dashboard
                </NavLink>
            }
        </>
    )
}