import { YellowButton } from "shared/ui/yellow-button"
import styles from "./header.module.css"
import { FincarLogoButton } from "shared/ui/fincar-logo-button/fincarLogoButton"

export const Header = () =>{
    return (
        <>
        <header className={styles.nav_wrapper}>
            <div className={styles.navbar_container}>
                <FincarLogoButton fontColor="yellow" />
                <YellowButton />
            </div>
        </header>
        </>
    )
}