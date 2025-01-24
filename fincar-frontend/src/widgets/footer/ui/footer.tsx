import { FincarLogoButton } from 'shared/ui/fincar-logo-button/fincarLogoButton'
import styles from './footer.module.css'
import githubLogo from 'shared/assets/icons/githubLogo.svg'
import { NavLink } from 'react-router-dom'

export const Footer = () => {
    return(
        <div className={styles.wrapper}>
            <div className={styles.container}>
                <div className={styles.leftContent}>
                    <FincarLogoButton fontColor='white' />
                </div>
                <div className={styles.rightContent}>
                    <p>Social networks</p>
                    <div>
                        <NavLink to="https://github.com/Fuad010/fincar-project">
                            <img src={githubLogo} alt="githubLogo" />
                        </NavLink>
                    </div>
                </div>
            </div>
        </div>
    )
}