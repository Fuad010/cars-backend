import { YellowButton } from "shared/ui/yellow-button"
import styles from "./header.module.css"
import { FincarLogoButton } from "shared/ui/fincar-logo-button/fincarLogoButton"
import homeHeaderBgImg from 'shared/assets/images/headerBg.png'
import { useLocation } from "react-router-dom"

export const Header = () =>{

    const location = useLocation();
    const isHomePage = location.pathname === '/home';

    return (
        <>
        {isHomePage ? (
            <header className={styles.home_header_container}>
                <img src={homeHeaderBgImg} alt="home_background"/>
                <div className={styles.home_nav_wrapper}>
                    <div className={styles.home_navbar}>
                        <div className={styles.home_navbar_content}>
                            <FincarLogoButton fontColor="white" />
                            <YellowButton />
                        </div>
                    </div>
                </div>
                <p>Own the car of your dreams with us</p>
            </header>
            ) : (
                <header className={styles.nav_wrapper}>
                <div className={styles.navbar}>
                    <FincarLogoButton fontColor="yellow" />
                    <YellowButton />
                </div>
            </header>
            )
        }
        </>
    )
}